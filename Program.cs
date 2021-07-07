using LGT_SDK_NETCORE.Client;
using LGT_SDK_NETCORE.Entities;
using es.logalty.bus.dataService;
using System;
using LGT_SDK_NETCORE.Util;
using System.Xml;
using SimuladorBackOffice.Models;
using ApiBack.Models;
using System.Collections.Generic;
using ConsultaEstadosLogalty.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ConsultaEstadosLogalty
{
    class Program
    {

        static void Main(string[] args)
        {
            var datos = resultado();
            ContratacionLogalty example = new ContratacionLogalty();
            
            guid[] guids = new guid[datos.Count];
            int count = 0;
            datos.ForEach(

                   datos1 => guids[count++] = new guid
                   {
                       Value = datos1.guid /*"001001-9996-000000001181482.par" *///input
                   }
                );

            WSBusData WSData = new WSBusData();
            XmlDocument xmlRequest = WSData.StampedBinaryPackRequestDocumentBuilder(guids);
            XMLSign utlSignXml = new XMLSign();
            XmlDocument xmlSigned = utlSignXml.BuildSigned(xmlRequest, example.Certificado);
            Console.WriteLine(("request: \n" + (xmlSigned.OuterXml)));

            LGT_SDK_NETCORE.Entities.DataResponse dataResponse = WSData.PostRequest(xmlSigned, example.Certificado, example.ConnectSetting);
            var guardardatos = resultadoConsulta(dataResponse.ResponseXml);

            Console.WriteLine(("State: "
                           + (dataResponse.Estado)));
            Console.WriteLine(guardardatos);
            Console.WriteLine(datos.Count);
            //Console.WriteLine(("GUID: "
            //                + (guids[0].Value)));
            //Console.WriteLine(("GUID: "
            //                + (guids[1].Value)));
            //Console.WriteLine(("Documento:" + (dataResponse.ResponseXml)));
            Console.WriteLine("Press <Enter> to exit StampedBinaryPackExample");
            Console.ReadLine();


        }

        public static List<ResultadoFeedback> resultado()
        {
            ContratacionLogalty example = new ContratacionLogalty();

            var _context = new ApiBckContext();
            var r = _context.ResultadoFeedback.FromSqlRaw<ResultadoFeedback>("EXEC dbo.firma_BuscarGuidFinalizadosSinFirmaDescarga;").ToList();
             _context.SaveChanges();
            return r;
        }

        public static List<State>resultadoConsulta(Object parameters)
        {
            ContratacionLogalty example = new ContratacionLogalty( );
            var _context = new ApiBckContext();
            var Respuestaxml = new SqlParameter("@Xmlrespuesta", parameters);

            var r = _context.State.FromSqlRaw<State>("EXEC GuardarDocumentoMasivoD @Xmlrespuesta",
              Respuestaxml ).ToList();
            _context.SaveChanges();
            return r;
        }

    }
}

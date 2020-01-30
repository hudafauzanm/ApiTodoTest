using System;
namespace ApiTest.Models
{
    public class Todos
    {
        public int id {get;set;}
        public string activity{get;set;}
        public string status {get;set;}
        public DateTime createdat{get;set;}
        public DateTime publishedat{get;set;}
    }
}
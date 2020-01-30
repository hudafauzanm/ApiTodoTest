using System;
using ApiTest.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;


namespace ApiTest.Controllers
{
    [Route("/todos")]
    
    [ApiController]

    public class Activity
    {
        private AppDb _appdb;

        public Activity(AppDb appdb)
        {
            _appdb = appdb;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Todos>> Get()
        {
            return _appdb.Todo;
        }

        [HttpGet("{id}")] 
        public ActionResult<Todos> Get(int id)
        {
            return _appdb.Todo.Find(id);
        }

        [HttpPost]
        public ActionResult<Todos> Post([FromBody] Todos todo)
        {
            _appdb.Add(todo);
            todo.status="Progress";
            todo.createdat=DateTime.Now;
            todo.publishedat=DateTime.Now;
            _appdb.SaveChanges();

            return todo;
        }

        [HttpPatch("{id}")]
        public ActionResult<Todos> Update(int id, [FromBody] Todos todoRequest)
        {
            var todo = _appdb.Todo.Find(id);
            todo.activity = todoRequest.activity;
            _appdb.SaveChanges();

            return todo;
        }

        
        [HttpPatch]
        [Route("/todos/done/{id}")]
        public ActionResult<Todos> Done(int id)
        {
            var todo = _appdb.Todo.Find(id);
            todo.status = "Done" ;
            _appdb.SaveChanges();

            return todo;
        }

        [HttpDelete("{id}")]
        public ActionResult<string> Delete(int id)
        {
            var activity = _appdb.Todo.Find(id);
            _appdb.Attach(activity);
            _appdb.Remove(activity);
            _appdb.SaveChanges();
            return $"Menghapus data ID: {id}";
        }
    }
}
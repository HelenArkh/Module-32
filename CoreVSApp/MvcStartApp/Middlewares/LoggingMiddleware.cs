using Microsoft.AspNetCore.Http;
using MvcStartApp.Models.Db;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace MvcStartApp.Middlewares
{
    public class LoggingMiddleware
    {
        private readonly RequestDelegate _next;
        //private IBlogRepository _repo;

        /// <summary>
        ///  Middleware-компонент должен иметь конструктор, принимающий RequestDelegate
        /// </summary>
        public LoggingMiddleware(RequestDelegate next/*, IBlogRepository repo*/)
        {
            _next = next;
            //_repo = repo;
        }

        private void LogConsole(HttpContext context)
        {
            // Для логирования данных о запросе используем свойста объекта HttpContext
            Console.WriteLine($"[{DateTime.Now}]: New request to http://{context.Request.Host.Value + context.Request.Path}");
        }

        private async Task LogFile(HttpContext context)
        {
            // Строка для публикации в лог
            string logMessage = $"[{DateTime.Now}]: New request to http://{context.Request.Host.Value + context.Request.Path}{Environment.NewLine}";

            // Путь до лога (опять-таки, используем свойства IWebHostEnvironment)
            string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), "Logs", "RequestLog.txt");

            // Используем асинхронную запись в файл
            await File.AppendAllTextAsync(logFilePath, logMessage);
        }

        /// <summary>
        ///  Необходимо реализовать метод Invoke  или InvokeAsync
        /// </summary>
        public async Task InvokeAsync(HttpContext context)
        {
            //string firstName = context.Request.Headers["FirstName"][0];
            //string lastName = context.Request.Headers["LastName"][0];

            //var newUser = new User()
            //{ Id = Guid.NewGuid(),
            //JoinDate = DateTime.Now,
            //FirstName = firstName,
            //    LastName = lastName


            //};

            //await _repo.AddUser(newUser);

            LogConsole(context);
            //await LogFile(context);

            // Передача запроса далее по конвейеру
            await _next.Invoke(context);
        }
    }
}

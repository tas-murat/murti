using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace WebUI.Extensions
{
    public class ErrorDetails
    {
        public string Message { get; set; }
        public int StatusCode { get; set; }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
			sb.AppendLine("<!DOCTYPE html>");
			sb.AppendLine("<html lang='en'>");
			sb.AppendLine("<head>");
			sb.AppendLine("<meta charset='utf-8'>");
			sb.AppendLine("<meta http-equiv='X-UA-Compatible' content='IE=edge'>");
			sb.AppendLine("<meta name='viewport' content='width=device-width, initial-scale=1'>");
			sb.AppendLine("<title>");
			sb.AppendLine(StatusCode+" - Error");
			sb.AppendLine("</title>");
			sb.AppendLine("<link href='https://fonts.googleapis.com/css?family=Montserrat:200,400,700' rel='stylesheet'>");
			sb.AppendLine("<link type='text/css' rel='stylesheet' href='css/error.css' />");
			sb.AppendLine("</head>");
			sb.AppendLine("<body>");
			sb.AppendLine("<div id='notfound'>");
			sb.AppendLine("<div class='notfound'>");
			sb.AppendLine("<div class='notfound-404'>");
			sb.AppendLine("<h1>Oops!</h1>");
			sb.AppendLine("<h2>");
			sb.AppendLine( StatusCode.ToString());
			sb.AppendLine( " -" );
			sb.AppendLine( Message );
			sb.AppendLine( "</h2>");
			sb.AppendLine("</div>");
			sb.AppendLine("<a href='/'>Go TO Homepage</a>");
			sb.AppendLine("</div>");
			sb.AppendLine("</div>");
			sb.AppendLine("</body>");
			sb.AppendLine("</html>");


            return sb.ToString();
        }
    }
}

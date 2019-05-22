using System;
using System.IO;
using Nancy;
using Nancy.Responses;

namespace Kyrsova.main.kyrsova.webServer
{
    public class GetPostRequests : NancyModule
    {
        public GetPostRequests()
        {
            int next = new Random().Next(0, 999999);

            Get["/"] = _ => View["index"];

            Get["/img.jpg"] = _ => getPhoto();
        }

        public static Response getPhoto()
        {
            var file = new FileStream(
                @"views\img.jpg",
                FileMode.Open);
            string fileName = "img.jpg";
            var response = new StreamResponse(() => file, MimeTypes.GetMimeType(fileName));
            return response.AsAttachment(fileName);;

        }
    }
}
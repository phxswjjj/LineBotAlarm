using RestSharp;
using System;
using System.Collections.Generic;
using System.Text;

namespace LintBotAlarm
{
    class LineNotify : ILineNotify
    {
        const string NOTIFY_URL = "https://notify-api.line.me/api/notify";

        private string Bearer { get; set; }
        private bool Notification { get; set; }

        private LineNotify(string bearer)
        {
            this.Bearer = bearer;
        }

        public static ILineNotify Create(string bearer, bool notification)
        {
            var notify = new LineNotify(bearer)
            {
                Notification = notification
            };
            return notify;
        }
        public static ILineNotify CreateError()
        {
            var bearer = "Bearer_XXX";
            return Create(bearer, true);
        }
        public static ILineNotify CreateInfo()
        {
            var bearer = "Bearer_XXX";
            return Create(bearer, false);
        }

        public void SendMessage(string message, bool notification)
        {
            var client = new RestClient(NOTIFY_URL);
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Bearer " + this.Bearer);
            request.AlwaysMultipartFormData = true;
            request.AddParameter("message", message);
            if (!notification)
                request.AddParameter("notificationDisabled", "true");
            IRestResponse response = client.Execute(request);
        }

        void ILineNotify.SendMessage(string message)
        {
            this.SendMessage(message, this.Notification);
        }
    }
}

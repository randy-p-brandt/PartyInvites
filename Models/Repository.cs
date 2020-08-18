using System.Collections.Generic;

namespace PartyInvites.Models
{
    public static class Repository
    {
        private static List<GuestResponse> responses = new List<GuestResponse>();
        public static IEnumerable<GuestResponse> Responses => responses;
        public static void AddResponse(GuestResponse response)
        {
            if (responses.Count < 1)
            {
                AddData();
            }
            responses.Add(response);
        }

        static void AddData()
        {
            GuestResponse gr = new GuestResponse();
            gr.Name = "Huey";
            gr.WillAttend = true;
            gr.Phone = "2145672234";
            gr.Email = "rtyu@bgfcfh.nic";
            responses.Add(gr);


            gr = new GuestResponse();
            gr.Name = "Mickey";
            gr.WillAttend = true;
            gr.Phone = "214567288";
            gr.Email = "rtrfyu@bgfcfh.nic";
            responses.Add(gr);
             
            gr = new GuestResponse();
            gr.Name = "Clutch";
            gr.WillAttend = true;
            gr.Phone = "233567288";
            gr.Email = "rtrfyu@bgfcfh.ggg";
            responses.Add(gr);


        }

    }

}

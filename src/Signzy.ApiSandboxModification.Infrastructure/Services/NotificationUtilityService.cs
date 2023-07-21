using Nippon.PaintPartner.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Nippon.PaintPartner.Infrastructure.Services
{
    public class NotificationUtilityService : INotificationUtilityService
    {
        public async Task<string> SendNotification(int UserId, int RegionId, int RowCount, string Title, string message, string FolderName, string ImageName, string ImageExt, string Status, CancellationToken cancellationToken)
        {
            try
            {
                // your RegistrationID paste here which is received from GCM server.                                                               
                string regId = RegionId.ToString();
                // applicationID means google Api key                                                                                                     
                var applicationID = "AIzaSyA_jXwfmuW-I8JyQGvxS5uKYKC7H3p2-54";
                // SENDER_ID is nothing but your ProjectID (from API Console- google code)//                                          
                var SENDER_ID = "122622964261";

                var value = message; //message text box                                                                               

                WebRequest tRequest;

                tRequest = WebRequest.Create("https://android.googleapis.com/gcm/send");

                tRequest.Method = "post";

                tRequest.ContentType = " application/x-www-form-urlencoded;charset=UTF-8";

                tRequest.Headers.Add(string.Format("Authorization: key={0}", applicationID));

                tRequest.Headers.Add(string.Format("Sender: id={0}", SENDER_ID));

                //Data post to server                                                                                                                                         
                string postData = "collapse_key=score_update&time_to_live=108&delay_while_idle=1&data.message=" + value + "&data.title=" + Title + "&data.Status=" + Status + "&data.Count=" + RowCount + "&data.foldername=" + FolderName + "&data.image=" + ImageName + "&data.imageext=" + ImageExt + "&data.time=" + System.DateTime.Now.ToString() + "&registration_id=" +
                                  regId + "";


                Byte[] byteArray = Encoding.UTF8.GetBytes(postData);

                tRequest.ContentLength = byteArray.Length;

                Stream dataStream = tRequest.GetRequestStream();

                dataStream.Write(byteArray, 0, byteArray.Length);

                dataStream.Close();

                WebResponse tResponse = tRequest.GetResponse();

                dataStream = tResponse.GetResponseStream();

                StreamReader tReader = new StreamReader(dataStream);

                String sResponseFromServer = tReader.ReadToEnd();   //Get response from GCM server.

                // Label3.Text = sResponseFromServer;      //Assigning GCM response to Label text 

                tReader.Close();

                dataStream.Close();
                tResponse.Close();
                return sResponseFromServer;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}

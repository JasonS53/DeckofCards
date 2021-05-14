using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace DeckofCardsAPI.Models
{
    public class DrawCardsDAL
    {
        public string GetDrawData(string deckId, int cardAmount)
        {
            string url = $"deckofcardsapi.com/api/deck/{}/draw/?count=5";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JSON;
        }

        public DrawCardsModel ConvertJsontoDrawCardsModel(string deckId, int cardAmount)
        {
            string data = GetDrawData(deckId, cardAmount);
            DrawCardsModel draw = JsonConvert.DeserializeObject<DrawCardsModel>(data);

            return draw;
        }
    }
}

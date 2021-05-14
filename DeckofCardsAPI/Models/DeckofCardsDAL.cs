using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading.Tasks;


namespace DeckofCardsAPI.Models
{
    public class DeckofCardsDAL
    {
        public string GetDeckData()
        {           
            string url = $"https://deckofcardsapi.com/api/deck/new/shuffle/?deck_count=1";

            HttpWebRequest request = WebRequest.CreateHttp(url);

            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            return JSON;
        }

        public DeckofCardsModel ConvertJsontoDeckofCardsModel()
        {
            string data = GetDeckData();
            DeckofCardsModel deck = JsonConvert.DeserializeObject<DeckofCardsModel>(data);

            return deck;
        }
    }
}

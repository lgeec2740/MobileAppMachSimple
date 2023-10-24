using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MobileAppMachSimple.Class
{
    public class GameDB
    {
        private List<Game> GameList = new List<Game>();
        private List<Publisher> PublisherList = new List<Publisher>();
        private int Gauto = 1;
        private int Pauto = 0;

        public Task<Game> GetGamesId(int id)
        {
            return Task.FromResult(GameList.Find(s => s.Id == id));
        }


        public Task<List<Game>> GetGames()
        {
            return Task.FromResult(GameList);
        }

        public Task<Publisher> GetPublisherId(int id)
        {
            return Task.FromResult(PublisherList.Find(s => s.Id == id));
        }

        public Task<List<Publisher>> GetPublishers()
        {
            return Task.FromResult(PublisherList);
        }

        public void AddGames(Game game)
        {
            GameList.Add(game);
            game.Id = Gauto;
            Gauto++;
        }



        public void AddPublisher(string publisherName)
        {
            Publisher publisher = new Publisher();
            publisher.Name = publisherName;
            PublisherList.Add(publisher);
            publisher.Id = Pauto;
            Pauto++;
        }

        public async Task EditGame(Game newGameEdit)
        {
            if (newGameEdit.Id == 0)
            {
                newGameEdit.Id = Gauto++;
                GameList.Add(newGameEdit);
            }
            else
            {
                Game oldGame = await GetGamesId(newGameEdit.Id);
                oldGame = newGameEdit;
            }
        }

        public async Task EditPublisher(Publisher publisher)
        {
            if (publisher != null)
            {

                publisher.Id = ++Pauto;
                PublisherList.Add(publisher);

            }
            else
            {
                Publisher oldPublisher = await GetPublisherId(publisher.Id);
                oldPublisher = publisher;
            }
        }

        public Task RemoveGame(Game game)
        {
            GameList.Remove(game);
            return Task.CompletedTask;
        }

        public Task RemovePublisher(Publisher publisher)
        {
            PublisherList.Remove(publisher);
            return Task.CompletedTask;
        }
    }
}

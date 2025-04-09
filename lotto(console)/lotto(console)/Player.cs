using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace lotto_console_
{
    public class Player
    {
        public string Name {  get; set; }
        public string Email { get; set; }
        public int Amount {  get; set; }

        public Player(string name, string email, int amount)
        {
            if (string.IsNullOrEmpty(name)) throw new ArgumentNullException("The player MUST have a Name");
            else Name = name;
            if (email.Contains('@') && email.Contains('.')) Email = email;
            else throw new ArgumentException("The email MUST have the right formate");

            string DoesHaveMoney()
            {
                if (amount <= 0) return "The player does not have money to play";
                else return "The player has money to play";
            }
            string MoneyOfPlayer()
            {
                return $"{amount} Ft";
            }
            void AddMoney(int addamount)
            {
                if (amount <= 0) throw new ArgumentException("You MUST add more money than zero!");
                else amount += addamount;
            }
            void Bet(int betamount)
            {
                if (betamount > amount) throw new ArgumentException("The bet BIGGER than the account");
                else amount -= betamount;
            }
        }
        public List<Player> PlayersHavingMoney(List<Player> PlayerList)
        {
            List<Player> list = new List<Player>();
            foreach (var item in PlayerList)
            {
                if (item.Amount > 0) list.Add(item);
            }
            return list;
        }
        public List<Player> PlayersHavingTMoreMoneyThanThis(List<Player> PlayerList, int limit)
        {
            List<Player> list = new List<Player>();
            foreach (var item in PlayerList)
            {
                if (item.Amount > limit) list.Add(item);
            }
            return list;
        }/*
        public int PaidMoneyToCompany(List<Player> PlayerList)
        {
            int money = 0;
            List<Player> list = new List<Player>();
            foreach (var item in PlayerList)
            {
                money
            }
            return list;
        }*/
    }
}


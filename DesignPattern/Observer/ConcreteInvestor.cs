using System;
namespace anodern.DesignPattern.Observer {
    class ConcreteInvestor:IInvestor {
        private string name;
        public ConcreteInvestor(string name) {
            this.name = name;
        }
        public void response(Player player) {
            Console.WriteLine("提醒玩家[{0}]:盟友[{1}]受到了攻击",name, player.Name);
        }
    }
}

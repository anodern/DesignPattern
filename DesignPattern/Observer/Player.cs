using System.Collections.Generic;
namespace anodern.DesignPattern.Observer {
    class Player {
        private List<IInvestor> investors;
        public string Name { get; set; }
        private float hp;
        public float HP {
            get => hp;
            set {
                if(value<hp) notifyInvestor();
                hp = value;
            }
        }
        public Player(string name,float hp) {
            this.Name = name;
            this.hp = hp;
            investors = new List<IInvestor>();
        }
        public void attatch(IInvestor investor) {
            investors.Add(investor);
        }
        public void detach(IInvestor investor) {
            investors.Remove(investor);
        }
        public void notifyInvestor() {
            foreach(IInvestor investor in investors) {
                investor.response(this);
            }
        }
    }
}

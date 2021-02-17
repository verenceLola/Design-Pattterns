using SimpleDuckAdapter.Interfaces;


namespace SimpleDuckAdapter.Entities {
    public class TurkeyAdapter :Duck {
        private Turkey _turkey;
        public TurkeyAdapter(Turkey turkey){
            _turkey = turkey;
        }
        public void quack(){
            _turkey.gobble();
        }
        public void fly(){
            for (int i = 0; i < 5; i++){
                _turkey.fly();
            }
        }
    }
}

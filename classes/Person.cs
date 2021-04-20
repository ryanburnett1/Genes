namespace Genes
{
    class Person<T> where T:Food
    {
        public Person() {
            Consumed = 0;
        }
        
        public int Consumed {get; set;}
        
        public void Eat(T food){
            Consumed += food.Energy;
        }
    }
}

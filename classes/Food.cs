namespace Genes
{
    public class Food
    {
        public Food(){
            Energy = 0;
        }
        public Food(int energy){
            Energy = energy;
        }
        
        public int Energy { get; }
    }
}
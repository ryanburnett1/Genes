namespace Genes
{
    class Environment{

        public Environment() {

        }
        public Person<Food>[] People {get; set;}

        public Food[] Foods {get; set;}

        public void populatePeople(int amt){
            People = new Person<Food>[amt];
        }
        public void populateFoods(int amt, int energy) {
            Foods = new Food[amt];
            for(int i = 0; i < amt; i++){
                Foods[i] = new Food(energy);
            }
        }

    }
}
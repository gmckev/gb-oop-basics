namespace MyLibrary
{
    public class Creator
    {
        private Creator()
        {

        }

        public static Building CreateBuilding()
        {
            return new Building();
        }

        public static Building CreateBuilding(float height, int floors, int flats, int entrances)
        {
            return new Building(height, floors, flats, entrances);
        }
    }
}

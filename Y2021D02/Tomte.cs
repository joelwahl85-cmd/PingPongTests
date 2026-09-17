namespace Y2021D02
{
    public class Tomte
    {
        public int CountTomteFloor(string[] floors){
			int _floor = 0;
	
			foreach	(var direction in floor){
				if (direction == ")"){
					_floor--;
				}
				else if (direction == "("){
					_floor++;
				}
			}
			
			return _floor;
		}
    }
}

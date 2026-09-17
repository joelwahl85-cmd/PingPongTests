namespace Y2021D02
{
    public class Tomte
    {
        public int CountTomteFloor(string floors){
			int _floor = 0;
	
			foreach	(var direction in floors){
				if (direction == ')'){
					_floor--;
				}
				else if (direction == '('){
					_floor++;
				}
			}
			
			return _floor;
		}

        public int FindFirstNegativeFloor(string floors)
        {
            int _floor = 0;
            int i = 0;

            foreach (var direction in floors)
            {
                if (direction == ')')
                {
                    _floor--;
                }
                else if (direction == '(')
                {
                    _floor++;
                }
                i++;
                if (_floor < 0)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}

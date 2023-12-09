using System;



namespace GraphEditor
{
    public class RIBSCLASS
    {
  
        public  PictureBox first;
        public  PictureBox second;
        public   Point firstloc;
        public   Point secondloc  ;
        public double weight;
        public PictureBox GetFirst()
        {
            return first;
        }
        public PictureBox GetSecond()
        {
            return second;
        }

        public Point GetFirstLoc() { 
            return firstloc;
                
                }
        public Point GetSecondLoc()
        {
            return secondloc;
        }

        public    RIBSCLASS ( PictureBox first ,PictureBox second, Point firstloc, Point secondloc)
        {
            this.first = first; 
            this.second = second;
            this.firstloc = firstloc;
            this.secondloc = secondloc;
            this.weight = 0;
        }
       public RIBSCLASS()
        {
            this.first = new PictureBox();
            this.second = new PictureBox();   
             this.firstloc = new Point();
            this.secondloc = new Point();
            this.weight= 0;
        }
   
        public static bool operator != (RIBSCLASS first, RIBSCLASS second)
        {
             if(first.first==second.first && first.second==second.second) { return false; }
             if(first.second == second.first&& first.second == second.second) { return false; }
             return true;
        }
        public static bool operator == (RIBSCLASS first,RIBSCLASS second)
        {
            if (first.first == second.first && first.second == second.second) { return true; }
            if (first.second == second.first && first.first == second.second) { return true; }
            return false;

        }

    }
}

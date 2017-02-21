using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Distances : IProgram
    {
        public void Run()
        {
            //Console.WriteLine("Enter the numbre of rows and columns separated by a blank space");
            //int[] arrayDimmensions = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();

            //Console.WriteLine("Enter the coordenates X Y separated by a blank space");
            //int[] coordsX = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();

            //Console.WriteLine("Enter the coordenates X Y separated by a blank space");
            //int[] coordsY = Console.ReadLine().Split(' ').Select(i => Convert.ToInt32(i)).ToArray();

            //for (int y = 0; y < arrayDimmensions[1]; y++)
            //{
            //    for (int x = 0; x < arrayDimmensions[0]; x++)
            //    {
            //        for (int i = 0; i < lockerXCoordinates.Length; i++) 
            //        {
            //            int distance = Math.Abs(lockerXCoordinates[i] - x) + Math.Abs(lockerYCoordinates[i] - y);
            //            distances[i][] = distance;
            //        }
                    
            //        //int distance = Math.Abs(coords[0] - x) + Math.Abs(coords[1] - y);
            //        //Console.Write(distance);
            //    }
            //    Console.WriteLine();
            
            //}



            List<int> numbers = new List<int> { 1, 5, 8, 3, 2 };
            var ar = numbers.OrderByDescending(c => c).ToArray();

            int cityLength = 5;
            int cityWidth = 7;
            int[] lockerXCoordinates = {2, 4};
            int[] lockerYCoordinates= {3,7};


            int[][] distances = new int[cityLength][];
        
            for(int y = 1; y <= cityWidth; y++) 
            {
                for(int x = 1; x <= cityLength; x++)
                {
                    var isSet = false;
                    for (int i = 0; i < lockerXCoordinates.Length; i++) 
                    {
                        if (distances[x - 1] == null)
                            distances[x - 1] = new int[cityWidth];

                        int distance = Math.Abs(lockerXCoordinates[i] - x) + Math.Abs(lockerYCoordinates[i] - y);
                        if (!isSet)
                        {
                            isSet = true;
                            distances[x - 1][y - 1] = distance;
                        }
                        else
                            distances[x - 1][y - 1] = distances[x - 1][y - 1] >= distance ? distance : distances[x - 1][y - 1];
                    }
                }
            }

            //return distances;
        }

        public List<string> getRankedCourses(string user)
        {
            List<string> Courses = new List<string>();

            List<string> firstCircleOfFriends = getDirectFriendsForUser(user);
            
            Dictionary<string, int> uniqueFriends = new Dictionary<string, int>();
            foreach (string friendId in firstCircleOfFriends)
            {
                //prevent same user to be included
                if (friendId == user)
                    continue;
                
                if (!uniqueFriends.Keys.Contains(friendId))
                    uniqueFriends.Add(friendId, 1);
                
                //Get the second circle
                var secondCircleOfFriends = getDirectFriendsForUser(friendId);
                
                foreach(string secondFriendId in secondCircleOfFriends)
                    if (!uniqueFriends.Keys.Contains(secondFriendId))
                        uniqueFriends.Add(secondFriendId, 2);
            }

            Dictionary<string, int> countCourses = new Dictionary<string, int>();

            foreach(string friendId in uniqueFriends.Keys)
            {
                List<string> courses = getAttendedCoursesForUser(friendId);
                foreach (string courseId in courses)
                {
                    if (!countCourses.Keys.Contains(courseId))
                        countCourses.Add(courseId, 1);
                    else
                        countCourses[courseId]++;
                }
            }

            Courses = countCourses.OrderByDescending(c => c.Value).Select(c => c.Key).ToList();
            return Courses;
        }

        private List<string> getAttendedCoursesForUser(string friendId)
        {
            throw new NotImplementedException();
        }

        private List<string> getDirectFriendsForUser(string user)
        {
            throw new NotImplementedException();
        }
    }
}

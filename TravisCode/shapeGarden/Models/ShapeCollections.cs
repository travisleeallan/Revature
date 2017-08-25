using System.Collections.Generic;

namespace ShapeGarden.Models
{
  public class ShapeCollection
  {
    public void ArrayGroup()
    {
      //1-d arrays
      int[] arr1 = {1,2,3};
      int[] arr2 = new int[]{4,5,6};
      int[] arr3 = new int[3];
    
      //m-d
      int[,] arr4 = {{1,2}, {3,4}};
      int[,] arr5 = new int[,] {{1,2}, {3,4}};
      int[,] arr6 = new int[2,2];

      //jagged
      int[][] arr7 = { new int[]{1,2}, new int[] {3} };

    }

    public void ListGroup()
    {
      List<int> li1 = new List<int>{1,2,3};
      List<int> li2 = new List<int>();

      li1.Add(4);
      li1[3] = 10;
      
    }

    public void DictionaryGroup()
    {
      Dictionary<string,string> d1 = new Dictionary<string,string>{{"name", "Travis"}};
      Dictionary<string,string> d2 = new Dictionary<string,string>();

      d1.Add("title", "troublemaker"); //this will error if "title" doesn't exist
      d1["last"] = "Allan"; //this will overide "last"
      
    }
  }
}
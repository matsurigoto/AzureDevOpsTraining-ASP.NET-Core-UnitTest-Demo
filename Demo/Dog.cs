using System.Collections.Generic;

namespace Demo
{
    public class Dog
    {
        public List<string> Bark(int count)
        {
            var response = new List<string>();

            for(var i = 0; i < count; i++)
            {
                response.Add("bark");
            }

            return response;
        }
    }
}

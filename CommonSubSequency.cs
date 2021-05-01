namespace problem_solving
{
    public class CommonSubSequency
    {
        public void calculate(string [] strArray){

            int j = 0; 
            string result = "";
            bool mainLoop = true;

            while(mainLoop) {
              
                string previous = "";

                for(int i = 0; i < strArray.Length; i++){

                    if(i == 0){
                        previous = strArray[i][j].ToString();
                        continue;
                    }

                    if(strArray[i][j].ToString() == previous){
                        previous = strArray[i][j].ToString();
                    } else{
                        mainLoop = false;
                        break;
                    }
                }

                if(mainLoop){
                   result += previous; 
                }
                
                j++;
            }


            System.Console.WriteLine(result);

        }
    }
}
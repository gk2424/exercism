public static class Raindrops
{
   public static string Convert(int number)
{
var answer = "";
if (number % 3 == 0)
{
answer += "Pling";
}
if (number % 5 == 0)
{
answer += "Plang";
}
if (number % 7 == 0)
{
answer += "Plong";
}
return answer != "" ? answer : number.ToString();
}
}
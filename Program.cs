// first task
int[] CelPosled = new[] {2,3,5,-7,4,-4};
int[] LINQCelPoled = (
    from CelPos in CelPosled
    where CelPos >   0
    select CelPos).ToArray();
//second task
int[] CelPosled1 = new[] {2,3,5,-7,4,-4};
int[] LINQCelPoled1 = (
    from CelPos in CelPosled
    where CelPos %2 != 0
    select CelPos).ToArray();
//third task
int[] CelPosled2 = new[] {2,3,5,-7,4, -4};
int[] LINQCelPoled2 = (
    from CelPos in CelPosled
    where CelPos %2 == 0
    select CelPos).ToArray();
//fourth task 
int[] CelPosled3 = new[] {23,34,5,-7,42,-4};
int[] LINQCelPoled3 = (
    from CelPos in CelPosled
    where CelPos %10 ==  1 && CelPos > 0
    select CelPos).ToArray();   
//fifth task
string[] StringArray = new[] {"sldks", "Gun", "George","dangeon", "master"};
string[] LINQStringArray = (
    from  StringArr in StringArray
    where StringArr.Length > 5 && StringArr.StartsWith('G')
    select StringArr).ToArray();
//sixth task
string[] StringArray1 = new[] {"sldks", "Gun", "George","dangeon", "master"};
string[] LINQStringArray1 = (
    from  StringArr in StringArray
    where StringArr.Length < 5 && StringArr.StartsWith('F')
    select StringArr).ToArray();
// seventh task
string[] StringArray2 = new[] {"sldks", "Gun", "George","dangeon", "master"};
char[] LINQStringArray2 = (
    from  StringArr in StringArray
    from Arr in StringArr.ToCharArray()
    where Arr == (StringArr.ToArray()).First()
    select Arr).ToArray();
foreach(char i in LINQStringArray2){
    Console.Write(i + " ");
}
//eighth task
int[] CelPosled4 = new[] {2,3,5,-7,4, -4};
string[] LINQStringArray3 = (
    from stringArr in CelPosled4
    where stringArr % 2 != 0 
    select stringArr.ToString()).ToArray();

import java.util.Scanner;

//Game about taking turns to pick sticks against the computer. 
//The winner is the one who does not pick the last stick.
public class Java21Sticks {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

	int antalPinnar = 21;
	System.out.println("Vill du börja?");
	Scanner input = new Scanner(System.in);
	String börja = input.nextLine();
	Scanner taPinne = new Scanner (System.in);
	int tagnaPinnar = 0;

while (antalPinnar > 0) {
		
	if (börja.equals("Ja") || börja.equals("ja")) 
	{
		System.out.println("Det finns " + antalPinnar + " pinnar, vill du ta 1 eller 2?");
		tagnaPinnar = taPinne.nextInt();

    if (tagnaPinnar > 2) 
    {
    	tagnaPinnar = 2;
    }
    else if (tagnaPinnar < 1) 
    {
    	tagnaPinnar = 1;	
    }
    antalPinnar = antalPinnar - tagnaPinnar;

	if (antalPinnar <=0) 
	{
		System.out.println ("Åh nej, datorn vinner :(");
    }
	
   else {

       if ((antalPinnar - 2) % 3 == 0 || antalPinnar - 2 == 0) 
       {
    	   tagnaPinnar = 1;
       }
       else 
       {
    	   tagnaPinnar = 2;
       }
       
        System.out.println("Datorn tar " + tagnaPinnar + " pinnar.");
	    antalPinnar = antalPinnar - tagnaPinnar;
	
	    if (antalPinnar <= 0) 
	    {
		System.out.println("Grattis, du vann!");
	    }
	}
}
else {
	
	if ((antalPinnar - 2) % 3 == 0 || antalPinnar - 2 == 0) 
	{
		tagnaPinnar = 1;
    }
	else 
	{
		tagnaPinnar = 2;
	}
		System.out.println("Datorn tar " + tagnaPinnar + " pinnar.");
		antalPinnar = antalPinnar - tagnaPinnar;
		
	if (antalPinnar <= 0) 
	{
	System.out.println("Grattis, du vann!");
	}
	
	else 
	{
		System.out.println("Det finns " + antalPinnar +", vill du ta 1 eller 2?");
		tagnaPinnar = taPinne.nextInt();

	if (tagnaPinnar > 2) 
	{
		tagnaPinnar = 2;
	}
	else if (tagnaPinnar < 1) 
	{
		tagnaPinnar = 1;	
	}
	antalPinnar = antalPinnar - tagnaPinnar;
	
		if (antalPinnar <=0) 
		{
			System.out.println ("Åh nej, datorn vinner :(");
		}
	}
}
}
}
}

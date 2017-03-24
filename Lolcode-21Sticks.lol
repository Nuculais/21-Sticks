HAI
BTW this game is about taking turns shooting traitors (based on the pen&paper RPG Paranoia) and not being the one to shoot the last one. 

I HAS A traitors 
traitors R 21
I HAS A dead 
dead R 0

VISIBLE "Want to take the first shot, citizen?"
GIMMEH answer

IM IN YR LOOP WILE traitors BIGGR OF traitors AN 0

BOTH SAEM answer and "yes" O RLY?
	YA RLY
		VISIBLE SMOOSH "There are, unfortunately " AN traitors AN " still alive. Will you shoot 1 or 2?" MKAY
	
	GIMMEH murders
	DIFFRINT murders AN BIGGR OF murders AN 1 O RLY?
		YA RLY
			dead R 2
		MEBBE DIFFRINT murders AN SMALLR OF murders AN 2
			dead R 1
		OIC
		
	traitors R DIFF OF traitors AN dead MKAY
	
	EITHER OF (traitors SMALLR of traitors AN 0) AN (BOTH SAEM traitors AN 0) O RLY?
		YA RLY
			VISIBLE "You have lost, therefore you must be a traitor, too. Prepare for termination."
		OIC	
	
	NO WAI BTW Computer gets to begin
	EITHER OF (BOTH SAEM (MOD OF (DIFF OF traitors AN 2) AN 3) AN 0) AN (BOTH SAEM (DIFF OF traitors AN 2) AN 0) O RLY?
		YA RLY
			dead R 1
		NO WAI
			dead R 2
		OIC
		
		VISIBLE SMOOSH "Friend Computer makes sure " AN dead AN " traitors are shot."		
		traitors R DIFF OF traitors AN dead
		
	EITHER OF (traitors SMALLR of traitors AN 0) AN (BOTH SAEM traitors AN 0) O RLY?
		YA RLY
			VISIBLE "You have won, therefore you must be a traitor, too. Prepare for termination."
		NO WAI
			VISIBLE SMOOSH "There are, unfortunately " AN traitors AN " still alive. Will you shoot 1 or 2?"
			GIMMEH murders
			
			DIFFRINT murders AN BIGGR OF murders AN 1 O RLY?
			YA RLY
				dead R 2
			MEBBE DIFFRINT murders AN SMALLR OF murders AN 2
				dead R 1
			OIC
		OIC
	traitors R DIFF OF traitors AN dead MKAY
	
	EITHER OF (traitors SMALLR of traitors AN 0) AN (BOTH SAEM traitors AN 0) O RLY?
		YA RLY
			VISIBLE "You have lost, therefore you must be a traitor, too. Prepare for termination."		
		OIC
	OIC
		
	IM OUTTA YR LOOP
		
KTHXBYE
		
		
		
		
		
			
		
		
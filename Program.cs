int stackNoParams(){
int num1 = 1000;
int num2 =200000000;
int [] array = new int [5] {100,200,300,400,500};
int num3= 4500000;
int greenland = num2 * num3;
int finland = -5;
int grass = 85;
int norway  = 45;
int dyson = 58;
int octogon = 589;
int hehe =7;
int grumble = -5;
int iceland = -5;
int adfsij = -5;
return num1;
}
//stackNoParams();
 int stackWithParams(int x){
int number2ish = x * x;
int number3ish = number2ish *x;
int number4ish = x-x;
return number2ish;
 }
 //stackWithParams(18);

void stackWithHeap(int a, int b, int c, string grum){
    string grum2=grum;
    int numer4 = a*b;
    int numer8 = c*b*a;
    string each= "According to all known laws of aviation, there is no way that a bee should be able to fly. Its wings are too small to get its fat little body off the ground. The bee, of course, flies anyway. Because bees don’t care what humans think is impossible.” SEQ. 75 - “INTRO TO BARRY” INT. BENSON HOUSE - DAY ANGLE ON: Sneakers on the ground. Camera PANS UP to reveal BARRY BENSON’S BEDROOM ANGLE ON: Barrys hand flipping through different sweaters in his closet. BARRY Yellow black, yellow black, yellow black, yellow black, yellow black, yellow black...oohh, black and yellow... ANGLE ON: Barry wearing the sweater he picked, looking in the mirror. BARRY (CONT’D) Yeah, let’s shake it up a little. He picks the black and yellow one. He then goes to the sink, takes the top off a CONTAINER OF HONEY, and puts some honey into his hair. He squirts some in his mouth and gargles. Then he takes the lid off the bottle, and rolls some on like deodorant. CUT TO: INT. BENSON HOUSE KITCHEN - CONTINUOUS Barry’s mother, JANET BENSON, yells up at Barry. JANET BENSON Barry, breakfast is ready! CUT TO:  - JS REVISIONS 8/13/07 1. INT. BARRY’S ROOM - CONTINUOUS BARRY Coming! SFX: Phone RINGING. Barry’s antennae vibrate as they RING like a phone. Barry’s hands are wet. He looks around for a towel. BARRY (CONT’D) Hang on a second! He wipes his hands on his sweater, and pulls his antennae down to his ear and mouth. BARRY (CONT'D) Hello? His best friend, ADAM FLAYMAN, is on the other end. ADAM Barry? BARRY Adam? ADAM Can you believe this is happening? BARRY Can’t believe it. I’ll pick you up. Barry sticks his stinger in a sharpener. SFX: BUZZING AS HIS STINGER IS SHARPENED. He tests the sharpness with his finger. SFX: Bing. BARRY (CONT’D) Looking sharp. ANGLE ON: Barry hovering down the hall, sliding down the staircase bannister. Barry’s mother, JANET BENSON, is in the kitchen. JANET BENSON Barry, why don’t you use the stairs? Your father paid good money for those. - JS REVISIONS 8/13/07 2. BARRY Sorry, I’m excited. Barry’s father, MARTIN BENSON, ENTERS. He’s reading a NEWSPAPER with the HEADLINE, “Queen gives birth to thousandtuplets: Resting Comfortably.” MARTIN BENSON Here’s the graduate. We’re very proud of you, Son. And a perfect report card, all B’s. JANET BENSON (mushing Barry’s hair) Very proud. BARRY Ma! I’ve got a thing going here. Barry re-adjusts his hair, starts to leave. JANET BENSON You’ve got some lint on your fuzz. She picks it off. BARRY Ow, that’s me! MARTIN BENSON Wave to us. We’ll be in row 118,000. Barry zips off. BARRY Bye! JANET BENSON Barry, I told you, stop flying in the house! CUT TO: SEQ. 750 - DRIVING TO GRADUATION EXT. BEE SUBURB - MORNING A GARAGE DOOR OPENS. Barry drives out in his CAR. - JS REVISIONS 8/13/07 3. ANGLE ON: Barry’s friend, ADAM FLAYMAN, standing by the curb. He’s reading a NEWSPAPER with the HEADLINE: “Frisbee Hits Hive: Internet Down. Bee-stander: “I heard a sound, and next thing I knew...wham-o!.” Barry drives up, stops in front of Adam. Adam jumps in. BARRY Hey, Adam. ADAM Hey, Barry. (pointing at Barry’s hair) Is that fuzz gel? BARRY A little. It’s a special day. Finally graduating. ADAM I never thought I’d make it. BARRY Yeah, three days of grade school, three days of high school. ADAM Those were so awkward. BARRY Three days of college. I’m glad I took off one day in the middle and just hitchhiked around the hive. ADAM You did come back different. They drive by a bee who’s jogging. ARTIE Hi Barry! BARRY (to a bee pedestrian) Hey Artie, growing a mustache? Looks good. Barry and Adam drive from the suburbs into the city. ADAM Hey, did you hear about Frankie? ";
}
stackWithHeap(5,68,99, "hello");

void stackoverflow(){
int [] crumb = new int [3];
stackoverflow();
}
Console.WriteLine("(1) stack with no parameters \n (2) stack with parameters \n (3) the heap \n (4) overflow");
int choosing = int.Parse(Console.ReadLine());
switch (choosing){
    case 1:
    stackNoParams();
    break;
    case 2:
    Console.WriteLine("choose a number");
    int answer = int.Parse(Console.ReadLine());
    stackWithParams(answer);
    break;
    case 3:
    Console.WriteLine("choose number 1");
      int numberone = int.Parse(Console.ReadLine());
      Console.WriteLine("choose number 2");
      int numbertwo = int.Parse(Console.ReadLine());
      Console.WriteLine("choose number 3");
        int number3 = int.Parse(Console.ReadLine());
        Console.WriteLine("what is your favorite word?");
        string word = Console.ReadLine();
        break;
        case 4:
        Console.WriteLine("stack blowing up in 3! 2! 1!");
        stackoverflow();
        break;
        default:
        Console.WriteLine("invalid input");
        break;
}
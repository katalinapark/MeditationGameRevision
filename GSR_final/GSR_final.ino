int GSR = A10; //PIN BEING READ FOR SENSOR

int sensorVal; // keeps value that is read on sensor
int average; // the average of the last 50 recorded values
long sum = 0; //for averaging
int index = 0; //used for array of sensor Num
boolean flag = false; //to see if a change was made previously


//variables to set
int sensitivity = 6; //how much of a jump the detector will react to
int sensorNum[50]; //always makes an average over last 50 readings

void setup() {
 Serial.begin(9600); //setting up serial communications
  for (int i = 0; i <50; i++) //fills in sensorNum array once at start
  {
    sensorVal = analogRead(GSR);
    sensorNum[i] = sensorVal;
    sum += sensorVal;
    delay(50);
    //Serial.println("*");
  }
  average = int(sum/50); //finds initial average
  //Serial.print("average= ");
 // Serial.println(average);

}


void loop() {
 
//  // put your main code here, to run repeatedly:
  sensorVal = analogRead(GSR); //reads GSR
 
  
  sensorNum[index]=sensorVal; //puts it into the array
  if(index <50) { //once the array is full, fills up array again from the beginning
    index++;
  }
  else {
    index = 0;
  }

  makeAverage(); //finds average of last 50 readings
  int difference = average - sensorVal; //finds difference between sensor value read and average
  
  if (abs(difference)>sensitivity) { //if there are any big changes, then checks again
    flag = true;
  }
  if (abs(difference)>sensitivity && flag == true) { //checking again to make sure
    //Serial.println("\n\n *********** CHANGE IN EMOTION ************\n\n");
    flag = false; //resets double checking
    delay(15);
  }
//prints out everything you need to keep track of
  /*Serial.print("sensorVal=");
  Serial.print(sensorVal);
   Serial.print("     average=");
  Serial.print(average);
  Serial.print("     difference=");*/
  Serial.println(difference);
  
  //can change this if you want
 delay(50);

}


//a function that finds the average of the last 50 readings
int makeAverage(){
   sum = 0;
   for (int i = 0; i <50; i++)
  {
    sum += sensorNum[i];
    //delay(50);
 //  Serial.print("*");
  }
  average = int(sum/50);
 
}


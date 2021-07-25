//Luke Mundy 15117108

void setup()
{
  size (1000,500);
}

//Ball details
int ballX = 500;
int ballY = 250;
int dirX = 5;
int dirY = round(random (-10,11));

//Paddle details
int paddleH = 200;
int paddleLX = 50;
int paddleLY = (height + paddleH)/2;
int paddleRX = 950;
int paddleRY = (height + paddleH)/2;

int moveSpeed = 5;

//Counters
int rally = 0;
int leftScore = 0;
int rightScore = 0;


void draw()
{
background(0);
fill(255);

textSize(20);
text("Rally: " + rally + " Left Score: " + leftScore + " Right Score: " + rightScore, 20, 30);


//left paddle
rect(paddleLX,paddleLY,10,paddleH);

//right paddle
rect(paddleRX,paddleRY,10,paddleH);

//ball
ellipse(ballX,ballY,10,10);
ballX=ballX+dirX;
ballY=ballY+dirY;



//collision
  //y boundry
  if (ballY<= 50 || ballY>=500)
      {
      dirY= -1*dirY;
      }
      
  
  //Paddle collision + rally count
  Boolean xCol = (ballX == paddleRX);
  Boolean yCol = (ballY >= paddleRY && ballY <= paddleRY + paddleH);

  if(xCol && yCol)
    {
       dirX *= -1;
       rally += 1;
    }
    
  xCol = (ballX == paddleLX);
  yCol = (ballY >= paddleLY && ballY <= paddleRY + paddleH);
   
    if(xCol && yCol)
    {
     dirX *= -1;
     rally += 1;
    }

//Score
  if (ballX<=5)
      {
      rightScore = rightScore + 1;
      rally -= rally;
      dirX *= -1;
      ballX = 500;
      ballY = 250;   
      dirY = round(random (-10,11));  
    }
      
   if  (ballX>=995)   
      {
      leftScore = leftScore + 1;
      rally -= rally;
      dirX *= -1;     
      ballX = 500;
      ballY = 250;
      dirY = round(random (-10,11));
  
} 
    }

void keyPressed()
{
  if(key==CODED)
 {
   
  if(keyCode==UP && paddleLY>0)
  {
 
    paddleLY=paddleLY-moveSpeed;
    }  
  
  
  if(keyCode==DOWN && paddleLY <=height-paddleH)
  {

    paddleLY=paddleLY+moveSpeed;
    
  }
  
    if(keyCode==RIGHT && paddleRY>=0)
  {
   
    paddleRY=paddleRY-moveSpeed;
    
  }
  
  if(keyCode==LEFT && paddleRY<=height-paddleH)
  {
 
    paddleRY=paddleRY+moveSpeed;
    }  
  
 }
}
void setup()
{
  size (1000,500);

}

float ballX = 500;
float ballY = 250;

float dirX = 10;//random(-2,2);
float dirY = 10;//random(-2,2);

float paddleLX = 50;
float paddleLY = 225;

float paddleRX = 950;
float paddleRY = 225;

float paddleH = 200;


void draw()
{
background(0);
fill(255);

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
  if (ballY<=0 || ballY>=500)
      {
      dirY= -1*dirY;
      }
      
  //x boundry  
  if (ballX<=0 || ballX>=1000)
      {
      dirX *= -1;
      }

Boolean xCol = (ballX == paddleRX);
Boolean yCol = (ballY >= paddleRY && ballY <= paddleRY + paddleH);

  if(xCol && yCol)
    {
       dirX *= -1;
    }
    
  xCol = (ballX == paddleLX);
  yCol = (ballY >= paddleLY && ballY <= paddleRY + paddleH);
   
    if(xCol && yCol)
    {
     dirX *= -1;
    }
}

void keyPressed()
{
  if(key==CODED)
 {
   
  if(keyCode==UP && paddleLY>0)
  {
    paddleLY=paddleLY-10;
  }
  
  if(keyCode==DOWN && paddleLY <=height-paddleH)
  {
    paddleLY=paddleLY+10;
  }
  
    if(keyCode==RIGHT && paddleRY>=0)
  {
    paddleRY=paddleRY-10;
  }
  
  if(keyCode==LEFT && paddleRY<=height-paddleH)
  {
    paddleRY=paddleRY+10;
  }
 }
}
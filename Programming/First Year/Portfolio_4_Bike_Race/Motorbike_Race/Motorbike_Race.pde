final color RED = color(255,0,0);
final color BLUE = color(0,0,255);
final color GREEN = color(0,255,0);
final int RACING=0;
final int FINISH=1;

int gameMode = RACING;



class motorbike
{
  int x = 5; //members
  int y;
  int speed=2;
  int size=30;
  color colour;
  
  
  motorbike(int y,color col)//constructor
  {
    this.y = y;
    //this.speed = (int)random(5.0);
    this.colour = col;
  }
  
  void render()
  {
     float wheelHeight = size/3;
     fill(colour);
     triangle(x,y,x+size,y,x+size/2,y-size/2); //built-in triangle routine
     drawWheel(x,y,wheelHeight);
     drawWheel(x+size,y,wheelHeight);
  }
  void drawWheel(int x,int y,float size)
  {
     float inner = size*2/3;
     fill(0);
     ellipse(x,y,size,size);
     fill(255);
     ellipse(x,y,inner,inner);
  }
  void move() 
  {
     speed = (int)random(5.0); //a random step [0..5]
     x+=speed;
  }
  void update() 
  {
     move();
     render();
  }
  
    boolean finished()
  {
   return x>(width-10); //screen width
  }

} //end of class description

 motorbike b1,b2,b3;
 
int winnerRed = 0;
int winnerGreen = 0;
int winnerBlue = 0;
int winCountR;
int winCountB;
int winCountG;
int winner;

void setup()
{
  size(1000,160);

  b1 = new motorbike(50,RED);
  b2 = new motorbike(70,BLUE);
  b3 = new motorbike(30,GREEN);
} 

void draw()
{
  background(200);
  fill(125);
  rect(0,0,width,10);
  rect(0,90,width,10);
  fill(50);
  rect(0,10,width,80);
  fill(255);
  rect(width-100,10,10,80);
  fill(0);
  
  text("Red Wins: " + winCountR+" Green Wins: "+winCountG+" Blue wins: "+ winCountB, 50,135);
  
  if(gameMode == 0)
{
  if(b1.finished() == false || b2.finished() == false || b3.finished() == false)
  {
    b1.update();
    b2.update();
    b3.render();
    
    if(b1.x >= (width-100))
    {
      winnerRed = 1;
      winCountR += 1;
      gameMode = FINISH;
    }
    
    if(b2.x >= (width-100))
    {
      winnerBlue =1;
      winCountB += 1;
      gameMode = FINISH;
    }
    
    if(b3.x >= (width-100))
    {
     winnerGreen = 1;
     winCountG += 1;
     gameMode = FINISH;
    }
   }
}
    else if(winnerRed == 1)
  {
    text("The winner is Red", 50,115);
    text("Press SPACEBAR to restart!", 50, 155);
  }
    else if(winnerBlue == 1)
  {
    text("The winner is Blue", 50,115);
    text("Press SPACEBAR to restart!", 50, 155);
  }
    else if(winnerGreen == 1)
  {
    text("The winner is Green", 50,115);
    text("Press SPACEBAR to restart!", 50, 155);
  }
}


void keyPressed()
{
  if(key == ' ' && gameMode==1)
  {
    gameMode = RACING;
    b1.x = 5;
    b2.x = 5;
    b3.x = 5;
    winnerRed = 0;
    winnerGreen = 0;
    winnerBlue = 0;
  }
}
void mousePressed()
{
  b3.x+=25;
}
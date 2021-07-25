PImage background;
int x =0;

Alien alien1 = new Alien (1100,200);
Shooter player1 = new Shooter (200);

void setup()
{
  size (1200,800);
  background = loadImage("city.png");
  background.resize (1200,800);
  image (background,0,0);
}

void draw()
{
  background(255);
  image(background,x,0);
  image(background,x + background.width,0);
  x=x-5;
  if(x<=-background.width)
  {
    x = 0;
  }
  
  boolean isAlienOutOfScreen = alien1.update();
  if (isAlienOutOfScreen == true)
   {
     alien1 = new Alien (1100,200);
   }
   
   player1.render();
   if (player1.crash() == true)
   {
   fill(255,0,0);
   text("CRASH",20,20);
   }

}

void keyPressed()
{
  if (key == CODED)
  {
    if (keyCode==UP && player1.y >= 20)
    {
      player1.y-=20;
    }
    if (keyCode==DOWN && player1.y <= height-40)
    {
      player1.y+=20;
    }
  }
}
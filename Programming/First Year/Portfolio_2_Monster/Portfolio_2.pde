int x = 50;
int y = 50;
int size = 50;


void setup()
{
  size (1000,500);
  for(int i=0; i<5; i++)
  {
    monsterDraw(x+i*100,y,size+i*10);
  }
}

void monsterDraw(int x, int y, int size)
{
  //face
  fill(0,255,0);
  rect (x,y,size,size*1.5);
  fill(255,255,255);
  
  //eye left
  ellipse(x+size*.2,y+size*.2,size/3,size/3);
  fill(0,0,0);
  ellipse(x+size/4,y+size/4,size/10,size/10);
  fill(255,255,255);
  
    
  //eye right
  ellipse(x+size*.8,y+size/5,size/3,size/3);
  fill(0,0,0);
  ellipse(x+size*.8,y+size/4,size/10,size/10);
  fill(255,255,255);
 
  //nose
  fill(255,0,0);
  ellipse(x+size*.5,y+size*.5,size*.2,size*.2);
  fill(255,255,255);
  
  //Horn
  line(x+size/4,y,x+size/2,y-size/4);
  line(x+size*0.75,y,x+size/2,y-size/4);
  
  //mouth
  line(x,y+size,x+size,y+size);
  line(x,y+size,x+size*.2,y+size*.8);
  line(x+size*.2,y+size*.8,x+size*.4,y+size);
  line(x+size,y+size,x+size*.8,y+size*.8);
  line(x+size*.6,y+size,x+size*.8,y+size*.8);
  
  
  
}
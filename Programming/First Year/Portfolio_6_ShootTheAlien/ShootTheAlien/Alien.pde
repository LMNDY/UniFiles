class Alien
{
  int x,y;
  Alien(int x, int y)
  {
    this.x=x;
    this.y=y;
  } 
  
  void render()
  {
    fill(255,0,0);
    ellipse(x,y,30,30);
    fill(0,0,255);
    ellipse(x,y,50,15);
  }
  
  boolean move()
  {
    x -=2;
    if(x<=0){return true;}
    else {return false;}
  }
  
  boolean update()
  {
    render();
    return move();
  }
  
}
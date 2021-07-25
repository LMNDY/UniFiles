//Luke Mundy 15117108

size (500,500);

int x = width/2;
int y = 100;
int scale = 3;


//head
ellipse(x,y,30*scale,30*scale);

//body
line(x,y,x,y+60*scale);

//arms
line(x-30*scale,y+30*scale,x+30*scale,y+30*scale);

//legs
line(x,y+60*scale,x-30*scale,y+90*scale);
line(x,y+60*scale,x+30*scale,y+90*scale);
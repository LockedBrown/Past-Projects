var n = 0;
var c = 4;
var s = 0.1;
function setup() {
	createCanvas(800,800);
	angleMode(DEGREES);
	colorMode(HSB);
	background(0);

}

function draw() {
	var a = n * 137.4;
	var r = c * sqrt(n);
	var x = r * cos(a) + width /2;
	var y = r * sin(a) + height /2;
	s += 0.01;
	fill(a % 256, 255, 255);
	noStroke();
	ellipse(x, y, s, s);


	if(s > 5)
	{
		s = 0.1;
	}
	n++;
} 
var s;
var scl = 20;
var food;
var munch;
var p;

function setup() {
	createCanvas(1300, 600);
	s = new Snake();
	p = new Player();

	frameRate(10);
    pickLocation();
    munchLocation();
 }

function pickLocation() {
	var cols = floor(600/scl);
	var rows = floor(600/scl);

	food = createVector(floor(random(cols)), floor(random(rows)));
	food.mult(scl);
}
function munchLocation(){
	var locationX = floor(600/scl);
	var locationY = floor(600/scl);
	munch = createVector(floor(random(locationX + 5, 65)), floor(random(locationY)));
	munch.mult(scl);

}

function draw() {
	background(51);
	fill(255);
 	rect(600, -1, 100, 601);

	if (s.eat(food)) {
 		pickLocation();

 	}
 	if (p.eat(munch)){
 		munchLocation();

 	}


 	p.update();
 	p.death();
 	p.show();
	s.update();
	s.death();
	s.show();


	fill(106, 247, 118);
	rect(food.x, food.y, scl, scl);

	fill(106, 247, 118);
	rect(munch.x, munch.y, scl, scl);

}

function keyPressed() {
	if (keyCode === UP_ARROW) {
		p.dir(0, -1);
	} else if (keyCode === DOWN_ARROW) {
		p.dir(0, 1);
	} else if (keyCode === RIGHT_ARROW) {
		p.dir(1, 0);
	} else if (keyCode === LEFT_ARROW) {
		p.dir(-1, 0);
	}
	if (key === 'w') {
		s.dir(0, -1);
	} else if (key === 's') {
		s.dir(0, 1);
	} else if (key === 'd') {
		s.dir(1, 0);
	} else if (key === 'a') {
		s.dir(-1, 0);
	}
}




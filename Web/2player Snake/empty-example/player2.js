function Player() {
	this.x = 0;
	this.y = 0;
	this.xspeed = 1;
	this.yspeed = 0;
	this.total = 0;
	this.tail = [];
	this.Player2 = 0;
	this.PlayerDeaths = 0;
	this.PlayerHS = 0;


	this.eat = function(pos) {
	var d = dist(this.x, this.y, pos.x, pos.y);
		if (d < 1) {
			this.total++;
			this.Player2 = this.Player2 + 1;
			if (this.Player2 > this.PlayerHS) {
				this.PlayerHS = this.Player2;
			}
			return true;
	 	} else {
	 	return false;
		 }
	 	}
		

	this.dir = function(x, y) {
		this.xspeed = x;
		this.yspeed = y;
	}

	this.death = function() {
		for (var i = 0; i < this.tail.length; i++) {
			var pos = this.tail[i];
			var d = dist(this.x, this.y, pos.x, pos.y);
			if (d < 1) {
				console.log('yes');
				this.total = 0;
				this.tail = [];
				this.Player2 = 0;
				this.PlayerDeaths = this.PlayerDeaths + 1;
							}
		}
	}

	this.update = function() {
		if (this.total === this.tail.length) {
		for (var i = 0; i < this.tail.length-1; i++) {
			this.tail[i] = this.tail[i+1];
		}
	}
		this.tail[this.total-1] = createVector(this.x, this.y);

		this.x = this.x + this.xspeed*scl;
		this.y = this.y + this.yspeed*scl;

		this.x = constrain(this.x, 600, 1340-scl);
		this.y = constrain(this.y, -20-scl, 640-scl);

		if (this.y > 590)
		{
			this.y = 0;
		}
		else if (this.y < 0)
		{
			this.y = 600;
		}
		else if (this.x > 1290)
		{
			this.x = 700;
		}
		else if (this.x < 690)
		{
			this.x = 1300;
		}


	}

	this.show = function() {
		fill(219, 74, 84);
		for (var i = 0; i < this.tail.length; i++) {
			rect(this.tail[i].x, this.tail[i].y, scl, scl);	
		}
		rect(this.x, this.y, scl, scl);

		fill(219, 74, 84);
		text("Score:", 603, 500);
		text("Died:", 603, 470);

		textSize(25);
		text(this.Player1, 671, 500);
		text(this.PlayerDeaths, 671, 470);

		textSize(24);
		text("Player: 2", 603, 530);
		text(this.Player2, 671, 501);

		textSize(20);
		text("Highscore:", 603, 300)
		textSize(24);	
		text(this.PlayerHS,635,265);		
	}

}


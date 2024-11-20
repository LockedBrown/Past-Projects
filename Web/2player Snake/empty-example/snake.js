function Snake() {
	this.x = 0;
	this.y = 0;
	this.xspeed = 1;
	this.yspeed = 0;
	this.total = 0;
	this.tail = [];
	this.Player1 = 0;
	this.PlayerDeaths = 0;
	this.PlayerHS = 0;


	this.eat = function(pos) {
	var d = dist(this.x, this.y, pos.x, pos.y);
		if (d < 1) {
			this.total++;
			this.Player1 = this.Player1 + 1;
			if (this.Player1 > this.PlayerHS) {
				this.PlayerHS = this.Player1;
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
				this.Player1 = 0;
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

		this.x = constrain(this.x, -20, 640-scl);
		this.y = constrain(this.y, -20, 640-scl);

		if (this.y >590)
		{
			this.y = 0;
		}
		else if (this.y < 0)
		{
			this.y = 600;
		}
		else if (this.x > 590)
		{
			this.x = 0;
		}
		else if (this.x < 0)
		{
			this.x = 600;
		}


	}

	this.show = function() {
		fill(58, 163, 209);
		for (var i = 0; i < this.tail.length; i++) {
			rect(this.tail[i].x, this.tail[i].y, scl, scl);	
		}
		rect(this.x, this.y, scl, scl);
		fill(58, 163, 209);
		text("Score:", 603, 100);
		text("Died:", 603, 130);
		textSize(25);
		text(this.Player1, 671, 101);
		text(this.PlayerDeaths, 671, 131);
		textSize(24);
		text("Player: 1", 603, 70);
		textSize(20);
		text("Highscore:", 603, 200)
		textSize(24);	
		text(this.PlayerHS,635,235);	
	}

}


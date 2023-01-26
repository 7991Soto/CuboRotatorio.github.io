html { background-image: url("https://2.bp.blogspot.com/-iCCUn-fktvk/UYVomjPC84I/AAAAAAAAAAc/czlS_SMG-rs/s1600/noise.png"), linear-gradient(to right, #444444, #8896a5);
  font-family: monospace;
  color: #fff;
  font-size: 1.3rem;
  line-height: 1.5;
}
a {color:#FF7361;}
#cont-cubo {
margin:100px auto;
perspective:600px;
animation:cont-cubo 10s infinite linear; linear;
}
.cubo {
position: relative;
margin: 0 auto;
height: 200px;
width: 200px;
animation:giro 25s infinite linear;
transform-style:preserve-3d;
}
.cubo div {
position: absolute;
height: 200px;
width: 200px;
-moz-cubo-shadow: 0px 0px 1px rgba(0, 0, 0, 0.5); /* Firefox anti aliasing */
animation:rotate 15s infinite linear;
}
.cubo div img {
  width:200px;
  height:200px;
  border-radius:200px;
  margin: 0; padding: 0; border: 0 none transparent;
animation:rot 5s infinite linear;
}
.cubo div.cara1 {
background:rgba(0,102,153,.5);
transform:translateZ(100px);
}
.cubo div.cara2 {
background:rgba(150,153,0,.7);
transform:rotateY(90deg) translateZ(100px);
}
.cubo div.cara3 {
background:rgba(39,116,61,.7);
transform:rotateY(180deg) translateZ(100px);
}
.cubo div.cara4 {
background:rgba(105,136,165,.7);
transform:rotateY(-90deg) translateZ(100px);
}
.cubo div.cara5 {
background:rgba(223,48,48,.7);
transform:rotateX(-90deg) translateZ(100px) rotate(180deg);
}
.cubo div.cara6 {
background:rgba(144,153,102,.7);
transform:rotateX(90deg) translateZ(100px);
}
@keyframes giro {
  0% {transform: rotateX(0deg)   rotateY(0deg);}
  100% {transform: rotateX(1080deg) rotateY(360deg);
  }
}
@keyframes rot {
  0% {transform: rotate(0deg);}
  100% {transform: rotate(360deg);}
 }
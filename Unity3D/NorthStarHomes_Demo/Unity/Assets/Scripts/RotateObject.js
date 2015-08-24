//****** Donations are greatly appreciated.  ******
//****** You can donate directly to Jesse through paypal at  jesse_etzler@yahoo.com   ******
 
var speed : int;
var lerpSpeed : float;
private var xDeg : float;
private var yDeg : float;
private var fromRotation : Quaternion;
private var toRotation : Quaternion;
 
function Update () {
 
        if(Input.GetMouseButton(0)) {
 
                xDeg -= Input.GetAxis("Mouse X") * speed;
                fromRotation = transform.rotation;
                toRotation = Quaternion.Euler(yDeg,xDeg,0);
                transform.rotation = Quaternion.Lerp(fromRotation,toRotation,Time.deltaTime * lerpSpeed);
        }
}
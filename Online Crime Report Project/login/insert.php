<?php
// form registration code
session_start();
if (isset($_POST['fname'])){
  $fname=$_POST['fname'];
  $lname=$_POST['lname'];
  $email=$_POST['email'];
  $number=$_POST['number'];
  $password=$_POST['password'];
  $confirmpassword=$_POST['confirmpassword'];
  
  #Email 
  /*$to = $email;
  $subject = "My subject";
  $txt = "You have successfully registered!!!!!!";
  $headers = "From:jayashreehacharya97@gmail.com";
  $check=mail($to,$subject,$txt,$headers);*/
  
  
$connect=mysqli_connect("localhost","root","","crimedb");

  
  $s="SELECT * FROM `login_insert` WHERE `fname`='$fname'";
  $t="SELECT * FROM `login_insert` WHERE `email`='$email'";
    
  $results = mysqli_query($connect,$s);
  $resultt = mysqli_query($connect,$t);
    
  $nums=mysqli_num_rows($results);
  $numt=mysqli_num_rows($resultt); 
  
  if($nums==1){
      echo("<html><center><form style='border: 4px solid black; margin-top:150px; margin-left:150px; margin-right:150px;'><h2 style='color:red;'>Username already exist!!!!</h2><p>[ If not login?? <a href='user_register.html'>Register</a> here..]</p></form></center></html>");
  }else if($numt==1){
      echo("<html><center><form style='border: 4px solid black; margin-top:150px; margin-left:150px; margin-right:150px;'><h2 style='color:red;'>Email already exist!!!!</h2><p>[ If not login?? <a href='user_register.html'>Register</a> here..]</p></form></center></html>");
  }else if($password!=$confirmpassword){
      echo("<html><center><form style='border: 4px solid black; margin-top:150px; margin-left:150px; margin-right:150px;'><h2 style='color:red;'>Password doesn't match!!!</h2><p>[ If not login?? <a href='user_register.html'>Register</a> here..]</p></form></center></html>");
  }
    else{
       $select="INSERT INTO `login_insert` (`fname`, `lname`, `email`, `number`, `password`, `confirmpassword`) VALUES ('$fname', '$lname', '$email', '$number', '$password', '$confirmpassword')";
       mysqli_query($connect,$select);
       $_SESSION["fname"]=$fname;
       echo("<html><center><form style='border: 4px solid black; margin-top:150px; margin-left:150px; margin-right:150px;'><h2 style='color:red;'>Congratulaions.....You have Registered Successfully....</h2><h3>Hey ".$_SESSION["fname"]. "<br><br><a href='user_login.html'>Login here</a></h3></form></center></html>");
       
  }


}
?>
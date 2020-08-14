<?php
session_start();
if (isset($_POST['name'])){
  $name=$_POST['name'];
  $email=$_POST['email'];
  $phone=$_POST['phone'];
  $address=$_POST['address'];
  $filetoupload=$_POST['filetoupload'];
  $selected=$_POST['selected'];
  $message=$_POST['message'];
  
  $connect=mysqli_connect("localhost","root","","crimedb");
  
  $s="SELECT * FROM `crime_report` WHERE `id`='$id'";
 
  $result=mysqli_query($connect,$s);
  
  $num=mysqli_num_rows($result);
  
  if($num==1){
      echo("<html><center><form style='border: 4px solid black; margin-top:150px; margin-left:150px; margin-right:150px;'><h2 style='color:red;'>Username already exist!!!!</h2></form></center></html>");
  } else{
       $select="INSERT INTO `crime_report` (`name`, `email`, `phone`, `address`, `filetoupload`, `selected`, `message`) VALUES ('$name', '$email', '$phone', '$address', '$filetoupload', '$selected', '$message');";
       mysqli_query($connect,$select);
       $_SESSION["name"]=$name;
       echo("<html><b>Congratulaions.....Reported Successfully....</b></html>".$_SESSION["name"]." ");
      echo '</br><a href="report-crime.php">Click here</a>';
       
  }

}
?>
<?php
session_start();
if (isset($_POST['name'])){
  $name=$_POST['name'];
  $email=$_POST['email'];
  $message=$_POST['message'];
  
  $connect=mysqli_connect("localhost","root","","crimedb");
  
  $s="SELECT * FROM `feedback` WHERE `id`='$id'";
 
  $result=mysqli_query($connect,$s);
  
  $num=mysqli_num_rows($result);
  
  if($num==1){
      echo("<html><center><form style='border: 4px solid black; margin-top:150px; margin-left:150px; margin-right:150px;'><h2 style='color:red;'>Error!!!!!</h2></form></center></html>");
  } else{
       $select="INSERT INTO `feedback` (`name`, `email`, `message`) VALUES ('$name', '$email', '$message');";
       mysqli_query($connect,$select);
  }

}
?>
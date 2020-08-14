<?php
 session_start();
 // $connect=mysqli_connect("localhost","id10839289_insert","123456","id10839289_crimedb");
 
$connect=mysqli_connect("localhost","root","","crimedb");
  $fname=$_POST['fname'];
  $email=$_POST['email'];
  $password=$_POST['password'];
  
  $s="SELECT * FROM `admin_login` WHERE `fname`='$fname' && `email`='$email' && `password`='$password'";
 
  $result=mysqli_query($connect,$s);
  
  $num=mysqli_num_rows($result);
  
 if($num==1){
        $home_url = '../login/admin/index.php';
        header('Location: '.$home_url);
        exit;
  } else if($fname!='fname' || $email!='email'){
        echo("<html><center><form style='border: 4px solid black; margin-top:150px; margin-left:150px; margin-right:150px;'><h2 style='color:red;'>Username or Email Not Matched!!!!</h2><p>[ If not login?? <a href='admin_login.html'>Register</a> here..]</p></form></center></html>");
  }
  
?>  
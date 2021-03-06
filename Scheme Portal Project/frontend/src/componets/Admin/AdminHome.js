import React, { Component,useState, Fragment } from 'react'
import {BrowserRouter as Router,Route,Switch} from 'react-router-dom';
import axios from "axios";
import {Redirect,Link} from 'react-router-dom'
import "../CSS/donor.css";

class MainHome extends Component {
  state = {
    scholerships: [],
    scholership_id:"",
    view:false
  };
  componentDidMount = async () => {
    const token = sessionStorage.getItem("token");
    const config = {
      headers: {
          Authorization: `Bearer ${token}`,
          "Content-Type": "application/json",
        },
      };
    const res = await axios.get(`http://localhost:5000/api/v1/scheme`, config);
      this.setState({
      scholerships: res.data.data,
    });
      console.log(this.state.scholerships);
  };
   
onClick = async (id,e) => {
 e.preventDefault();
 this.setState({
       view:true,
       scholership_id:id,
 });
}

render() {
 return (
    <Fragment>
    {this.state.view ?
    ( 
        (<Redirect view={this.state.view} 
          to={{pathname:'/vendor/view_scholership',
                  state:{scholership_id:this.state.scholership_id}
              }} 
          />) 
       )
    : 
    (
        
    <section class="counts section-bg mt-5">
        <div className=" container-fluid mt-5" id="product">
          <h4> Official Dashboard</h4>
          <h2> List Of Schemes</h2>

            <div className="row">
            {this.state.scholerships.map((scholership) => (
              <div className="col-lg-3 col-md-3 col-sm-3   animated fadeInUp wow animated">
               <div className="card product-top">
                <img 
                  src={scholership.file}
                  className="img1"
                  alt=""
                />
                 <div className="product-bottom text-center">
               
            <h5 className="text-dark">{scholership.title}</h5>
            <h6 className="text-dark">{scholership.eligibility}</h6>
            <h6 className="text-dark">{scholership.lastdate}</h6>
             </div>
                <div className="overlay">
                  <a onClick={(e) =>this.onClick(scholership._id,e)}>
                    <i className="fa fa-eye"></i>
                  </a>
                </div>
              </div>
            
            </div>
            

            ))}
         
          
          </div>
        </div>
        </section>
      )}
      </Fragment>
    );
  }
}

export default MainHome;

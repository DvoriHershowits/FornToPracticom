import Child from "./Child";

export default class Parent{
    constructor( 
      public id :number, public idNumberParent:string,public firstName:string,
      public lastName:string,public dateOfBirth:Date,public maleOrFemale:string,
      public hmo:string,public children:Child[]
     ){}
}
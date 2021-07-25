package com.example.graham.lm15117108;

import java.io.Serializable;


    /**
     * Created by lukem on 29/03/2018.
     */

    public class Student implements Serializable {

        private String name;
        private String gender;
        private String dob;
        private String address;
        private String postcode;
        private int studentNumber;
        private String courseTitle;
        private String startDate;
        private int bursary;
        private String email;

        public Student(String name, String gender, String dob, String address, String postcode,
                       int studentNumber, String courseTitle, String startDate, int bursary,
                       String email){
            this.name = name;
            this.gender = gender;
            this.dob = dob;
            this.address = address;
            this.postcode = postcode;
            this.studentNumber = studentNumber;
            this.courseTitle = courseTitle;
            this.startDate = startDate;
            this.bursary = bursary;
            this.email = email;
        }

        public String getName(){return name;}
        public void setName(String name){this.name = name;}

        public String getGender(){return gender;}
        public void setGender(String gender){this.gender = gender;}

        public String getDob(){return dob;}
        public void setDob(String dob){this.dob = dob;}

        public String getAddress(){return address;}
        public void setAddress(String address){this.address = address;}

        public String getPostcode(){return postcode;}
        public void setPostcode(String postcode){this.postcode=postcode;}

        public int getStudentNumber(){return studentNumber;}
        public void setStudentNumber(int studentNumber){this.studentNumber = studentNumber;}

        public String getCourseTitle(){return courseTitle;}
        public void setCourseTitle(String courseTitle){this.courseTitle = courseTitle;}

        public String  getStartDate(){return startDate;}
        public void setStartDate(String startDate){this.startDate = startDate;}

        public int getBursary(){return bursary;}
        public void setBursary(int bursary){this.bursary = bursary;}

        public String getEmail(){return email;}
        public void setEmail(String email){this.email = email;}


}

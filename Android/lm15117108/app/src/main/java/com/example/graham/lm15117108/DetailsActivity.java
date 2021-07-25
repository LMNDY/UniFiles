package com.example.graham.lm15117108;

import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

public class DetailsActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_details);

        Bundle extras = getIntent().getExtras();
        Student theStudentData = (Student) extras.get("students");

        TextView name = findViewById(R.id.detailName);
        TextView gender = findViewById(R.id.detailGender);
        TextView dob = findViewById(R.id.detailDOB);
        TextView address = findViewById(R.id.detailAddress);
        TextView postcode = findViewById(R.id.detailPostcode);
        TextView studentNumber = findViewById(R.id.detailStudentNumber);
        TextView courseTitle = findViewById(R.id.detailCourseTitle);
        TextView startDate = findViewById(R.id.detailStartDate);
        TextView bursary = findViewById(R.id.detailBursary);
        TextView email = findViewById(R.id.detailEmail);

        name.setText(theStudentData.getName());
        gender.setText(theStudentData.getGender());
        dob.setText(theStudentData.getDob());
        address.setText(theStudentData.getAddress());
        postcode.setText(theStudentData.getPostcode());
        studentNumber.setText(Integer.toString(theStudentData.getStudentNumber()));
        courseTitle.setText(theStudentData.getCourseTitle());
        startDate.setText(theStudentData.getStartDate());
        bursary.setText(Float.toString(theStudentData.getBursary()));
        email.setText(theStudentData.getEmail());
    }
}

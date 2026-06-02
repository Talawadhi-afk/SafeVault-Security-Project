# Security Tests

## SQL Injection Test

Input:
' OR '1'='1

Expected Result:
Login denied

Status:
Passed

## XSS Test

Input:
<script>alert('XSS')</script>

Expected Result:
Script rendered as text

Status:
Passed

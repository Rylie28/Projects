# IT Help Desk Application

## Overview

The **IT Help Desk** is an intranet-based application designed to help organizations manage IT-related problems that occur during project development. The system provides a centralized platform where project members can submit support tickets, IT support staff can resolve or share tickets, and report managers can monitor and assign high-priority issues.

The application also provides online help resources, frequently reported problems, email notifications, ticket prioritization, and reporting functionality.

## Features

* **User Registration & Login**

  * Administrators can register users.
  * Users receive unique login credentials to access the system.

* **Online Help**

  * Provides documentation and tutorials to help users resolve common problems.
  * Supports documents such as PDF and DOC files.

* **Existing Problem List**

  * Displays frequently reported problems and their solutions.
  * Helps users find solutions to common issues before submitting a new ticket.

* **Ticket Management**

  * Project members can create support tickets describing their problems.
  * Users can view the status of submitted tickets.
  * Closed tickets can be reopened if the problem was not properly resolved.

* **Ticket Resolution**

  * IT support team members can view and solve submitted tickets.
  * Tickets can be shared with other IT support members when additional assistance is required.

* **Ticket Monitoring & Assignment**

  * Report managers can monitor ticket status.
  * High-priority tickets can be assigned to IT support team members.
  * Tickets can be automatically prioritized when they exceed their Service Level Agreement (SLA).

* **Reporting**

  * Generates reports showing ticket activity, including solved and unsolved tickets.

* **Email Notifications**

  * Sends email alerts when tickets are raised, updated, solved, or shared.
  * Notifications include relevant date and time information.

## User Roles

### Administrator

Administrators are responsible for:

* Registering users
* Generating reports
* Managing email alerts

### Project Member

Project members can:

* Log into the system
* Access online help
* View frequently reported problems
* Create support tickets
* Reopen previously closed tickets

### IT Support Team

IT support members can:

* View and solve tickets
* Update ticket solutions
* Share tickets with other support team members

### Report Manager

Report managers can:

* Monitor ticket status
* Assign high-priority tickets to IT support team members

## System Components

The application consists of the following major components:

1. Registration
2. Login
3. Online Help
4. Existing Problem List
5. Raise Ticket
6. Re-open Ticket
7. Solve Ticket
8. Share Ticket
9. Monitor Ticket
10. Assign Ticket
11. Report Generation
12. Email Alerts

## Ticket Workflow

A typical support request follows this process:

```text
Project Member
      |
      v
  Raise Ticket
      |
      v
IT Support Team
      |
      +------> Solve Ticket
      |
      +------> Share Ticket
                    |
                    v
              Other Support Member
      |
      v
  Ticket Updated
      |
      v
  Email Notification
```

If a ticket is closed without providing an appropriate solution, the project member can reopen the ticket and raise the problem again.

Tickets that are not resolved within the defined SLA can also receive increased priority.

## System Relationships

The major system components interact as follows:

* **Registration → Login**

  * Registered users receive credentials that allow them to access the system.

* **Raise Ticket → Existing Problem List**

  * Previously submitted tickets can be used to identify frequently occurring problems.

* **Raise Ticket → Re-open Ticket**

  * Previously raised tickets can be reopened when a problem has not been properly resolved.

* **Raise Ticket → Solve Ticket**

  * IT support members are responsible for resolving submitted tickets.

* **Solve Ticket → Share Ticket**

  * Support members can transfer tickets to other team members when they cannot resolve an issue.

* **Solve/Share Ticket → Email Alert**

  * Users can receive email notifications about ticket activity.

* **Tickets → Reports**

  * Ticket information is used to generate reports about system activity.

## Requirements & Constraints

The original project specification identifies several system requirements and environmental constraints:

* An internet connection is required for information sharing and email alerts.
* Adobe Reader and Lotus Symphony are identified as requirements for accessing online help documents.
* A web browser and Java plugins are identified as required system software.

## Project Scope

The IT Help Desk is intended to provide employees with a centralized platform for communicating IT problems and managing their resolution.

The system supports:

* Employee authentication
* Problem documentation and tutorials
* Ticket creation and tracking
* Ticket prioritization
* Ticket assignment
* Ticket sharing
* Ticket reopening
* Ticket resolution
* Reporting
* Email notifications

## Project Purpose

The primary goal of the IT Help Desk is to improve communication between project members and IT support teams by providing a centralized system for reporting, tracking, resolving, and monitoring technical issues.

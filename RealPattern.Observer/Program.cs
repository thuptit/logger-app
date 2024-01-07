/*
 * Observer pattern: a system need to send notification when update anything
 */

using RealPattern.Observer;

var subject = new NotifySubject();
var email = new EmailService(subject);
var jira = new JiraService(subject);
var teams = new TeamsService(subject);

email.Subscribe();
jira.Subscribe();

subject.NotifyAll();
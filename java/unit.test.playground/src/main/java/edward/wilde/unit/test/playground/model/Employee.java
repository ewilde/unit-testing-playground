package edward.wilde.unit.test.playground.model;

import edward.wilde.unit.test.playground.services.*;
public class Employee {
	private IService<Employee> service;
	
	public Employee(IService<Employee> service) {
		this.service = service;
	}
	
	public void Save() {
		this.service.Save(this);
	}
}

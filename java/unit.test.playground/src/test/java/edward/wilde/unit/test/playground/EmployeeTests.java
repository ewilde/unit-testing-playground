package edward.wilde.unit.test.playground;

import edward.wilde.unit.test.playground.model.*;
import edward.wilde.unit.test.playground.services.*;
import junit.framework.TestCase;
import static org.mockito.Mockito.*;

public class EmployeeTests extends TestCase {

	@SuppressWarnings("unchecked")
	public void testSave() {
		IService<Employee> service = (IService<Employee>) mock(IService.class);
		Employee subject = new Employee(service);
		
		subject.Save();
		
		verify(service).Save(subject);
	}
}

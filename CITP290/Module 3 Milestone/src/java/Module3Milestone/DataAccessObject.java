/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package Module3Milestone;

import java.util.*;

/**
 *
 * @author tyler
 */
public interface DataAccessObject <E> {
    List<E> readAll();
    E read(Object id);
    void create(E entity);
    void update(E entity);
    void delete(Object id);
}
